import { Router } from "express";
import usersRouter from "./users/users-routes";
import serviceRoutes from "./services";
import graphQlRouter from "./graphql";

const routes = Router();

routes.use("/services", serviceRoutes);

routes.use("/api/users", usersRouter);

routes.use("/graphql", graphQlRouter);

export default routes;
