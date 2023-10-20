var gcd = function (a, b) {
    if (!b) {
        return a;
    }

    return gcd(b, a % b);
};

/**
 * @param {string} str1
 * @param {string} str2
 * @return {string}
 */
var gcdOfStrings = function (str1, str2) {
    // Check if they have non-zero GCD string.
    if (str1 + str2 != str2 + str1) {
        return "";
    }

    let gcdLenght = gcd(str1.length, str2.length);
    return str1.substring(0, gcdLenght);
};

var str1 = "ABCABC";
var str2 = "ABC";

console.log(gcdOfStrings(str1, str2));

str1 = "Leet";
str2 = "Code";

console.log(gcdOfStrings(str1, str2));
