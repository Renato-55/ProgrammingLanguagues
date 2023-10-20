/**
 * @param {Array<Function>} functions
 * @return {Promise<any>}
 */
var promiseAll = function (functions) {
    return new Promise(function (resolve, reject) {
        var results = [];
        var count = 0;
        var _loop_1 = function (i) {
            functions[i]()
                .then(function (result) {
                    results[i] = result;
                    count++;
                    if (count === functions.length) {
                        resolve(results);
                    }
                })
                .catch(function (err) {
                    reject(err);
                });
        };
        for (var i = 0; i < functions.length; i++) {
            _loop_1(i);
        }
    });
};

/**
 * const promise = promiseAll([() => new Promise(res => res(42))])
 * promise.then(console.log); // [42]
 */
