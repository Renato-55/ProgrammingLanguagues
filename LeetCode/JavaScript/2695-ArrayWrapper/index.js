/**
 * @param {number[]} nums
 * @return {void}
 */
var ArrayWrapper = function (nums) {
    this.nums = nums;
};

/**
 * @return {number}
 */
ArrayWrapper.prototype.valueOf = function () {
    return this.nums.reduce((a, b) => a + b, 0);
};

/**
 * @return {string}
 */
ArrayWrapper.prototype.toString = function () {
    return `[${this.nums.join(",")}]`;
};

// const obj1 = new ArrayWrapper([1, 2]);
// const obj2 = new ArrayWrapper([3, 4]);
const obj1 = new ArrayWrapper([]);
const obj2 = new ArrayWrapper([]);

console.log(obj1 + obj2); // 10
// obj1 + obj2; // 10

String(obj1); // "[1,2]"
String(obj2); // "[3,4]"
console.log(String(obj1) + String(obj2)); // "[1,2][3,4]"
