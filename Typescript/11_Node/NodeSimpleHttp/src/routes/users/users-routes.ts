import { Request, Response, Router } from "express";
import { getUsers, getUser } from "../../controllers/users/users-controller";

const usersRouter = Router();

/* 
    Route : /api/users
    Method : GET
    Description : Get all users
// */
usersRouter.get("/", getUsers);

/* 
    Route : /api/users/:uid
    Method : GET
    Description : Get all users
// */
usersRouter.get("/:uid", getUser);

export default usersRouter;
