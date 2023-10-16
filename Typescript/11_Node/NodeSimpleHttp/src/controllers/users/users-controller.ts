import { PrismaClient } from "@prisma/client";
import { NextFunction, Request, Response } from "express";
import HttpError from "../../models/http-error";

export const getUsers = async (req: Request, res: Response) => {
    const prisma = new PrismaClient();
    const users = await prisma.user.findMany();
    res.status(200).json(users);
};

export const getUser = async (
    req: Request,
    res: Response,
    next: NextFunction
) => {
    const prisma = new PrismaClient();

    const user = await prisma.user.findUnique({
        where: {
            id: Number(req.params.uid),
        },
    });

    if (!user) {
        return res.status(404).json({ message: "User not found" });
    }
    return res.status(200).json(user);
};
