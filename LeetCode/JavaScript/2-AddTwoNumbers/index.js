/**
 * Definition for singly-linked list.
 * function ListNode(val, next) {
 *     this.val = (val===undefined ? 0 : val)
 *     this.next = (next===undefined ? null : next)
 * }
 */

var invertNumber = (number) => {
    var result = 0;

    while (number > 0) {
        result = result * 10 + (number % 10);
        number = Math.floor(number / 10);
    }

    return result;
};
/**
 * @param {ListNode} l1
 * @param {ListNode} l2
 * @return {ListNode}
 */
var addTwoNumbers2 = function (l1, l2) {
    var l1Inverted = 0,
        l2Inverted = 0;
    for (let i = 0; i < l1.length; i++) {
        l1Inverted += l1[i] * Math.pow(10, i);
    }

    for (let i = 0; i < l2.length; i++) {
        l2Inverted += l2[i] * Math.pow(10, i);
    }

    return invertNumber(l1Inverted + l2Inverted)
        .toString()
        .split("")
        .map((x) => Number(x));
};

let l1 = [2, 4, 3],
    l2 = [5, 6, 4];

// 2 -> 4 -> 3 : 3 4 2
// 5 -> 6 -> 4 : 4 6 5
// 3 + 4 = 7, 4 + 6 = 10, 2 + 5 = 7

console.log(addTwoNumbers2(l1, l2));

(l1 = []), (l2 = []);

console.log(addTwoNumbers2(l1, l2));

(l1 = [9, 9, 9, 9, 9, 9, 9]), (l2 = [9, 9, 9, 9]);
