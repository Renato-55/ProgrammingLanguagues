/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function (arr, fn) {
    return arr.filter(fn);
};

// whithout filter

/**
 * @param {number[]} arr
 * @param {Function} fn
 * @return {number[]}
 */
var filter = function (arr, fn) {
    res = [];
    i = 0;
    arr.forEach((element) => {
        if (fn(element, i)) {
            res.push(element);
        }
        i = i + 1;
    });

    return res;
};