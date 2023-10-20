/**
 * @param {string} s
 * @return {number}
 */
var myAtoi = function (s) {
    let numbers = s.replace(/^\s+/, "").match(/^[-+]?[0-9]+/);

    if (isNaN(numbers)) {
        return 0;
    }

    if (numbers < Math.pow(-2, 31)) {
        return Math.pow(-2, 31);
    } else if (numbers > Math.pow(2, 31)) {
        return Math.pow(2, 31);
    }

    return Number(numbers);
};

console.log(myAtoi("42")); // 42
console.log(myAtoi("   -42")); // -42
console.log(myAtoi("4193 with words")); // 4193
console.log(myAtoi("-91283472332")); // -2147483648
console.log(myAtoi("21474836460")); // 2147483647
