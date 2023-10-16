import { PrismaClient } from "@prisma/client";
import { NextFunction, Request, Response } from "express";

export const seedUsers = async (req: Request, res: Response) => {
    const prisma = new PrismaClient();
    const users = await prisma.user.createMany({
        data: [
            {
                name: "Alice",
                email: "alice@demo.com",
            },
            {
                name: "Bob",
                email: "bob@demo.com",
            },
            {
                name: "Charlie",
                email: "charlie@demo.com",
            },
            {
                name: "Tina",
                email: "tina@demo.com",
            },
        ],
    });

    res.status(200).json(users);
};
