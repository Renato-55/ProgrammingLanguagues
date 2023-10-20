/**
 * @param {Array} arr
 * @param {Function} fn
 * @return {Array}
 */
var sortBy = function (arr, fn) {
    res = [];

    res = arr.sort(fn);

    return res;
};

arr = [5, 4, 1, 2, 3];
fn = (x) => x;

console.log(sortBy(arr, fn)); // [1, 2, 3, 4, 5]
