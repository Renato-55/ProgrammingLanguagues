/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
// var reduce = function(nums, fn, init) {
//     return nums.reduce(fn, init)
// };

// whitout reduce

/**
 * @param {number[]} nums
 * @param {Function} fn
 * @param {number} init
 * @return {number}
 */
var reduce = function (nums, fn, init) {
    res = init;
    nums.forEach( (element) => {
        res = fn(res, element);
    });
    return res;
};

var reduceFn = (accum, curr) => {
    return accum + curr;
}
console.log(reduce([1, 2, 3, 4], reduceFn, 0));