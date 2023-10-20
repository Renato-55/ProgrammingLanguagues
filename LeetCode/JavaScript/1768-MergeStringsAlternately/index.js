/**
 * @param {string} word1
 * @param {string} word2
 * @return {string}
 */
var mergeAlternately = function (word1, word2) {
    var minorLenght = word1.length < word2.length ? word1.length : word2.length;
    var isWord1Minor = word1.length < word2.length ? true : false;
    var result = "";

    for (let index = 0; index < minorLenght; index++) {
        result += word1[index] + word2[index];
    }

    result += isWord1Minor
        ? word2.substring(minorLenght)
        : word1.substring(minorLenght);
    return result;
};

world1 = "abccccccccc";
world2 = "pqrrrrr";

console.log(mergeAlternately(world1, world2));
