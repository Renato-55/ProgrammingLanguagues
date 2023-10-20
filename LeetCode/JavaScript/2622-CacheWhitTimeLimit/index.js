var TimeLimitedCache = function () {
    this.cache = new Map();
};

/**
 * @param {number} key
 * @param {number} value
 * @param {number} duration time until expiration in ms
 * @return {boolean} if un-expired key already existed
 */
TimeLimitedCache.prototype.set = function (key, value, duration) {
    const found = this.cache.has(key);

    if (found) clearTimeout(this.cache.get(key).ref);

    this.cache.set(key, {
        value,
        ref: setTimeout(() => {
            this.cache.delete(key);
        }, duration),
    });
    return found;
};

/**
 * @param {number} key
 * @return {number} value associated with key
 */
TimeLimitedCache.prototype.get = function (key) {
    return this.cache.has(key) ? this.cache.get(key).value : -1;
};

/**
 * @return {number} count of non-expired keys
 */
TimeLimitedCache.prototype.count = function () {
    return this.cache.size;
};

/**
 * const timeLimitedCache = new TimeLimitedCache()
 * timeLimitedCache.set(1, 42, 1000); // false
 * timeLimitedCache.get(1) // 42
 * timeLimitedCache.count() // 1
 */

const timeLimitedCache = new TimeLimitedCache();
timeLimitedCache.set(1, 42, 1000); // false
timeLimitedCache.set(3, 42, 20); // false
timeLimitedCache.get(1); // 42
timeLimitedCache.count(); // 1

console.log("Dellaying for cache to be expired");
setTimeout(() => {
    console.log(timeLimitedCache.get(1));
    console.log(timeLimitedCache.count());
}, 1100);

// testCache = new Map();
// testCache.set(1, { key: 1, value: 42, expired: false });
// value = testCache.get(1);
// console.log("Key: ", value.key);
// console.log("Value: ", value.value);
// console.log("Expired: ", value.expired);
