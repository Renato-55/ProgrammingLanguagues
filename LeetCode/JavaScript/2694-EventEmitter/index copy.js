callback = () => {
    return 99;
};
callback2 = () => {
    return 999;
};
test = {};

if (test["onClick"] === undefined) {
    test["onClick"] = [];
}

test["onClick"].push(callback);
test["onClick"].push(callback2);

outputs = [];
for (const key in test["onClick"]) {
    outputs.push(test["onClick"][key]());
}
console.log(outputs);
