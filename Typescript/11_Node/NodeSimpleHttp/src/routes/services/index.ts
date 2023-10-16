import { Router } from "express";
import seedUsersRouter from "./seeddata/seed_users";

const serviceRoutes = Router();

serviceRoutes.use("/seed_data/seed_users", seedUsersRouter);

export default serviceRoutes;
