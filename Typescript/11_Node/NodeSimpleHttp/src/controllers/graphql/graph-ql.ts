import { PrismaClient } from "@prisma/client";
import { NextFunction, Request, Response } from "express";
import HttpError from "../../models/http-error";
import { graphql, buildSchema } from "graphql";

// Construct a schema, using GraphQL schema language
var schema = buildSchema(`
  type Query {
    hello: String,
    greet(name: String!): String
  }
`);

// The rootValue provides a resolver function for each API endpoint
var rootValue = {
    hello: () => {
        return "Hello world!";
    },
    greet: ({ name }: { name: string }) => {
        return `Hello, ${name}!`;
    },
};

export const rootFn = async (req: Request, res: Response) => {
    graphql({
        schema,
        source: '{ hello, greet(name: "Alice") }',
        rootValue,
    }).then((response) => {
        console.log(response);
        return res.status(200).json(response);
    });
};
