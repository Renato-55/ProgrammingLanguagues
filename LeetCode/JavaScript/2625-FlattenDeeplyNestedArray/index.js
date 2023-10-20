/**
 * @param {Array} arr
 * @param {number} depth
 * @return {Array}
 */
var flat = function (arr, n) {
    // flatArray = arr;

    // while (n != 0) {
    //     flatArray = flatArray.reduce((acc, val) => {
    //         return acc.concat(val);
    //     }, []);
    //     n = n - 1;
    // }
    // return flatArray;

    return arr.flat(n);
};

arr = [1, 2, 3, [4, 5, 6], [7, 8, [9, 10, 11], 12], [13, 14, 15]];
n = 1;

console.log(flat(arr, n));
