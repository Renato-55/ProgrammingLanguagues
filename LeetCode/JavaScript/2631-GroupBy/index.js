/**
 * @param {Function} fn
 * @return {Object}
 */
Array.prototype.groupBy = function (fn) {
    res = {};

    this.forEach((el) => {
        const key = fn(el);
        if (!res[key]) {
            res[key] = [];
        }
        res[key].push(el);
    });
    return res;
};

console.log([1, 2, 3].groupBy(String));
