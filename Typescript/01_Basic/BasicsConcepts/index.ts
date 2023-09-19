//#region Typescript Types
/**
 * Typescript Types
 * - Boolean
 * - Number
 * - String
 *
 * Less comon types [bigint, symbol, undefined, null]
 */

import { type } from "os";

// Types can be explicit or implicit
let implicitBoolean = true;
let explicitBoolean: boolean = false;

// any is a special type that can be used to avoid type checking
let anyType: any = 1;
anyType = "string";

// unknown is a special type that can be used to avoid type checking
// let unknownType: unknown = 1;
// unknownType = "string";
//#endregion

//#region Typescript Arrays
console.log("\nTypescript Arrays");
/**
 * Typescript Arrays
 * - Array<T> or T[]
 */
const names: string[] = ["John", "Jane", "Joe"];

// add to array
names.push("Jack");

console.log("[+] Array: ", names);
/**
 * Tuple
 * - Fixed length array
 * - Fixed type array
 * - Good pratice to make it readonly
 */
const tuple: [string, number] = ["John", 1];

tuple.push("Jane");

console.log("[+] Tuple: ", tuple);
//#endregion

//#region Typescript Objects
console.log("\nTypescript Objects");
const car: {
  type: string;
  model: string;
  year: number;
} = {
  type: "car",
  model: "Ford",
  year: 2020,
};
console.log("[+] Object: ", car);
console.log("[+] isObject ? ", typeof car === "object");
//#endregion

//#region Typescript Enums, Interfaces
console.log("\nTypescript Enums, Interfaces");
enum Color {
  Red,
  Green,
  Blue,
}
const color: Color = Color.Red;

console.log("[+] Enum: ", color);
console.log("[+] Enum to string: ", Color[color]);
console.log("[+] isEnum ? ", typeof color === "number");

interface Person {
  name: string;
  age: number;
}

type dogType = {
  name: string;
  age: number;
  breed: string;
};

// Interfaces can be used to define the type of an object or a function
// Types can be used to define the type of an object or a function
// Whats is the difference between interfaces and types?
// R:
let person: Person = {
  name: "John",
  age: 20,
};

let dog: dogType = {
  name: "Rex",
  age: 2,
  breed: "Labrador",
};
console.log("[+] Interface: ", person);
console.log("[+] Type: ", dog);

// Extend Interfaces
interface AsianPerson extends Person {
  makeSushi: () => void;
}

let asianPerson: AsianPerson = {
  name: "John",
  age: 20,
  makeSushi: (): string => "Making sushi",
};

console.log("[+] Extended Interface: ", asianPerson);
console.log("\t[-] AsianPerson making sushi: ", asianPerson.makeSushi());
//#endregion

//#region Typescript Unions Types
console.log("\nTypescript Unions Types");
// Union types are used to define a variable that can have multiple types
let unionType: string | number = 1;
unionType = "string";
console.log("[+] Union type: ", unionType);
console.log("[+] isUnion type string ? ", typeof unionType === "string");
unionType = 1;
console.log("[+] Union type: ", unionType);
console.log("[+] isUnion type string ? ", typeof unionType === "string");
//#endregion

//#region Typescript Functions
console.log("\nTypescript Functions");
// Functions can have multiple types
function add(a: number, b: number): number {
  return a + b;
}
console.log("[+] Function add: ", add(1, 2));
console.log("\t[-] isFunction add ? ", typeof add);
console.log("\t[-] return type of add ? ", typeof add(1, 2));

// Functions can be declared as arrow functions
const addArrow = (a: number, b: number): number => {
  return a + b;
};
console.log("[+] Function addArrow: ", addArrow(1, 2));
console.log("\t[-] isFunction addArrow ? ", typeof addArrow);
console.log("\t[-] return type of addArrow ? ", typeof addArrow(1, 2));

// Functions can have default and option parameters
function addDefault(a: number, b: number = 0, c?: number): number {
  return a + b;
}
console.log("[+] Function addDefault whit one parameter", addDefault(1));
console.log(
  "[+] Function addDefault whit two parameters (mandatory and default)",
  addDefault(1, 2)
);
console.log(
  "[+] Function addDefault whit three parameters (mandotory, optional and defualt)",
  addDefault(1, 2, 3)
);
//#endregion

//#region Typescript Casts
console.log("\nTypescript Casts");
// Casts are used to convert a variable to a specific type
let cast: any = "string";
console.log("[+] Cast: ", cast);
console.log("\t[-] isCast a string ? ", typeof cast === "string");

if (typeof cast === "string") {
    console.log("\t[-] Cast to string: ", cast as string);
} else {
    console.log("\t[-] Cast cannot be casted to string");
}
//#endregion

//#region Typescript Classes
console.log("\nTypescript Classes");
// Classes are used to create objects
class Fruit {
    name: string;
    color: string;
    isEatable: boolean;
    readonly id: number;
    /**
     * Constructor
     * - is a special method that is called when an object is created
     * - is used to initialize the object
     * - comes by default if not defined
     */
    constructor() {
        // get random id
        this.id = Math.floor(Math.random() * 1000);
        this.name = "";
        this.color = "";
        this.isEatable = false;
    }

    eating(): string {
        return "Eating fruit";
    }

    toString(): string {
        return `Fruit: ${this.name} - ${this.color} - ${this.isEatable} - ${this.id}`;
    }
}

// to create an object of the class we use the new keyword
let fruit = new Fruit();
fruit.name = "Apple";
fruit.color = "Red";
fruit.isEatable = true;

console.log("[+] Class Fruit: ", fruit);
console.log("\t[-] Fruit eating: ", fruit.eating());
console.log("\t[-] Fruit toString: ", fruit.toString());

console.log("[+] Classes can have 3 types of access modifiers");
console.log("\t[-] public: can be accessed from anywhere");
console.log("\t[-] private: can only be accessed from inside the class");
console.log("\t[-] protected: can only be accessed from inside the class and from classes that extend the class");
//#endregion

console.log("\n");
