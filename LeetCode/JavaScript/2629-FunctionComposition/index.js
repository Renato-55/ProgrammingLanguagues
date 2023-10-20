/**
 * @param {Function[]} functions
 * @return {Function}
 */
var compose = function (functions) {
    return function (x) {
        value = x;
        functions.reverse().forEach((_func) => {
            value = _func(value);
            console.log(value);
        });
        return value;
    }
};

const fn = compose([ x => 2 * x, x => x + 1])
console.log(fn(4)) // 9