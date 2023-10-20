/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function (arr, fn) {
    return arr.map(fn)
};

// whitout map

/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var map = function (arr, fn) {
    res = [];
    i = 0;
    arr.forEach((element) => {
        res.push(fn(element, i))
        i += 1;
    });

    return res;
};