/**
 * @param {number[]} flowerbed
 * @param {number} n
 * @return {boolean}
 */
var canPlaceFlowers = function (flowerbed, n) {
    numberOfFlowers = 0;

    for (let index = 0; index < flowerbed.length; index++) {
        let element = flowerbed[index];
        let plant = false;
        if (!element) {
            let isLeftPlanted = true,
                isRightPlanted = true;
            // check right
            if (index === 0) {
                isLeftPlanted = false;
                isRightPlanted = flowerbed[index + 1];
            } else if (index === flowerbed.length - 1) {
                isLeftPlanted = flowerbed[index - 1];
                isRightPlanted = false;
            } else {
                isLeftPlanted = flowerbed[index - 1];
                isRightPlanted = flowerbed[index + 1];
            }
            plant = !isLeftPlanted && !isRightPlanted;
        }

        if (plant) {
            flowerbed[index] = 1;
            numberOfFlowers += 1;
        }
    }
    console.log(numberOfFlowers, n, flowerbed);
    return numberOfFlowers >= n;
};

console.log(canPlaceFlowers([1, 0, 0, 0, 1], 2));

function canPlaceFlowers2(flowerbed, n) {
    let noAdjacent = 0;

    flowerbed.forEach((_value, index) => {
        const prev = index - 1;
        const next = index + 1;

        if (!flowerbed[prev] && !flowerbed[index] && !flowerbed[next]) {
            noAdjacent++;
            flowerbed[index] = 1;
        }
    });

    return noAdjacent >= n;
}

console.log(canPlaceFlowers2([1, 0, 0, 0, 1], 2));
