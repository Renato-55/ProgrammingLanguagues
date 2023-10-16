import { Request, Response, Router } from "express";
import { getUsers, getUser } from "../../controllers/users/users-controller";
import { rootFn } from "../../controllers/graphql/graph-ql";

const graphQlRootRouter = Router();

/* 
    Route : /graphql/root
    Method : GET
    Description : -----
// */
graphQlRootRouter.get("/", rootFn);

export default graphQlRootRouter;
