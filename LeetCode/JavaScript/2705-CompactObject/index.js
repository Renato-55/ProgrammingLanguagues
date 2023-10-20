/**
 * @param {Object|Array} obj
 * @return {Object|Array}
 */
var compactObject = function (obj) {
    // These three if statements deal with when obj is not an iterable object
    // Steps 1-3 as described above
    if (obj === null) return null;
    if (Array.isArray(obj)) return obj.filter(Boolean).map(compactObject);
    if (typeof obj !== "object") return obj;

    // This for loop deals with when obj is an iterable object
    // Steps 4-5 as described above
    const compacted = {};
    for (const key in obj) {
        let value = compactObject(obj[key]);
        if (Boolean(value)) compacted[key] = value;
    }

    return compacted;
};

// var obj = [1, 3, 634, 326, 4334, 0, 223, 3, "", 0, [0]];
// console.log(compactObject(obj)); // should output [1,3,634,326,4334,223,3,"",[]]

// obj = [null, 0, false, 1];
// console.log(compactObject(obj)); // should output [1]

// obj = { a: null, b: [false, 1] };
// console.log(compactObject(obj)); // should output { b: [1] }

var test = [1, 3, 634, 326, 4334, 0, 223, 3, "", 0, [0]];

console.log(test.filter(Boolean));
