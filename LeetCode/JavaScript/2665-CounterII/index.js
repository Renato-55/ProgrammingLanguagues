var createCounter = function (init) {
    var currentValue = init;

    var increment = () => {
        return currentValue += 1;
    }
    var decrement = () => {
        return currentValue -= 1;
    }
    var reset = () => {
        return currentValue = init;
    }

    return { increment, decrement, reset }
};


const counter = createCounter(5)
console.log(counter.increment()); // 6
console.log(counter.reset()); // 5
console.log(counter.decrement()); // 4
