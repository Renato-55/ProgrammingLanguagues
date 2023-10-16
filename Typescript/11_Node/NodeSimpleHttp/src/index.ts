import express, { Request, Response, Application, NextFunction } from "express";
import cors from "cors";
import HttpError from "./models/http-error";
import routes from "./routes";

const app: Application = express();

const PORT = process.env.PORT || 5000;

const allowedOrigins = ["http://localhost:3000"];

const options: cors.CorsOptions = {
    origin: allowedOrigins,
};

// Then pass these options to cors:
app.use(cors(options));

app.use(express.json());

/**
 * Add Routes here
 */
app.use(routes);

app.use((req: Request, res: Response, next: NextFunction) => {
    const error = new HttpError("Route Not Found", 404);
    next(error);
});

app.use((error: HttpError, req: Request, res: Response, next: NextFunction) => {
    if (res.headersSent) {
        return next(error);
    }
    res.status(error.statusCode || 500);
    res.json({ message: error.message || "An unknown error occurred!" });
});

console.log("Connected to database!");
console.log(`Server Running here 👉 http://localhost:${PORT}`);
app.listen(PORT);
