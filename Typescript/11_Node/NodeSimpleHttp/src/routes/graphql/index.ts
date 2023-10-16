import { Router } from "express";
import graphQlRootRouter from "./root";
const graphQlRouter = Router();

graphQlRouter.use("/root", graphQlRootRouter);

export default graphQlRouter;
