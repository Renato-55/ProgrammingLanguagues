class Calculator {
    /**
     * @param {number} value
     */
    constructor(value) {
        this.number = value;
    }

    /**
     * @param {number} value
     * @return {Calculator}
     */
    add(value) {
        this.number += value;
        return this;
    }

    /**
     * @param {number} value
     * @return {Calculator}
     */
    subtract(value) {
        this.number -= value;
        return this;
    }

    /**
     * @param {number} value
     * @return {Calculator}
     */
    multiply(value) {
        this.number *= value;
        return this;
    }

    /**
     * @param {number} value
     * @return {Calculator}
     */
    divide(value) {
        if (value === 0) throw new Error("Division by zero.");
        this.number /= value;
        return this;
    }

    /**
     * @param {number} value
     * @return {Calculator}
     */
    power(value) {
        this.number **= value;
        return this;
    }

    /**
     * @return {number}
     */
    getResult() {
        return this.number;
    }
}
