import { Request, Response, Router } from "express";
import { seedUsers } from "../../../util/services/seeddata/seedusers-service";

const seedUsersRouter = Router();

/* 
    Route : /services/seed_data/seed_users
    Method : GET
    Description : Creates some demo users in the database
// */
seedUsersRouter.get("/", seedUsers);

export default seedUsersRouter;
