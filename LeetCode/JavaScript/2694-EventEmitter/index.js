class EventEmitter {
    constructor() {
        this.events = {};
    }

    /**
     * @param {string} eventName
     * @param {Function} callback
     * @return {Object}
     */
    subscribe(eventName, callback) {
        if (this.events[eventName] === undefined) {
            this.events[eventName] = [];
        }

        this.events[eventName].push(callback);

        return {
            unsubscribe: () => {
                console.log(this.events);
                this.events[eventName] = this.events[eventName].filter(
                    (_callback) => _callback !== callback
                );
                console.log(this.events);
            },
        };
    }

    /**
     * @param {string} eventName
     * @param {Array} args
     * @return {Array}
     */
    emit(eventName, args = []) {
        let events = this.events[eventName];
        if (events) {
            let outputs = [];
            events.forEach((event) => {
                outputs.push(event(...args));
            });
            return outputs;
        }
        return [];
    }
}

eventEmitter = new EventEmitter();

function1 = (args) => {
    return args + 1;
};
function2 = (args) => {
    return args + 2;
};

const sub1 = eventEmitter.subscribe("event1", function1);
const sub2 = eventEmitter.subscribe("event1", function2);

sub1.unsubscribe();

console.log(eventEmitter.emit("event1", 2));
