#!/usr/bin/env node
import axios from 'axios'
import * as chalk from 'chalk'
import 'colorts/lib/string';

// to run this code must install axios and chalk,
// npm install --save axios
// npm install --save chalk

axios.get('https://httpbin.org/ip')
    .then((response) => {
        console.log(`Your IP is ${response.data.origin}`.cyan);  
    });
