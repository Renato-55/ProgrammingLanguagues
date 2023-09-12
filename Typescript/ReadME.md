# TypeScript

Typescript is a superset of Javascript whit the adition of static typing

## Typescript Installation

Typescript official compiler can be installed through npm

Within your npm project, run the following command to install the compiler:

`npm install typescript --save-dev`

Which should give you an output similar to:

added 1 package, and audited 2 packages in 2s
found 0 vulnerabilities

The compiler is installed in the `node_modules` directory and can be run with: `npx tsc`.

`npx tsc`

Which should give you an output similar to:

Version 4.5.5
tsc: The TypeScript Compiler - Version 4.5.5

Followed by a list of all the Commmon Commands.

By default the TypeScript compiler will print a help message when run in an empty project.

The compiler can be configured using a `tsconfig.json` file.

You can have TypeScript create `tsconfig.json` with the recommended settings with:

`npx tsc --init`

## Setup a console App

To create a new typescript console app use one of these.

[TypeScript tutorial with Visual Studio Code](https://code.visualstudio.com/docs/typescript/typescript-tutorial)

https://galdin.dev/blog/writing-a-node-console-app-in-typescript/
