var expect = function (val) {
    var toBe = (_val) => {
        if (val !== _val) throw new Error("Not Equal")
        return true;
    };

    var notToBe = (_val) => {
        if (val === _val) throw new Error("Equal")
        return true;
    };

    return { toBe, notToBe };
};

console.log(expect(1).toBe(1));
console.log(expect(1).notToBe(1));