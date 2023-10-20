/**
 * @param {Function} fn
 * @return {Function}
 */
var once = function (fn) {
    let runned = false;
	return function (...args) {
        if (!runned) {
            runned = true;
            return fn(...args)
        }
        else {
            return undefined;
        }
	}
};


let fn = (a,b,c) => {
    console.log(a + " " + b + " " + c)
    return (a + b + c)
};
let onceFn = once(fn)
console.log(onceFn(1,2,3)); // 6
// console.log(onceFn(2,3,6)); // returns undefined without calling fn
