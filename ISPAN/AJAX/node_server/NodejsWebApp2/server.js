////'use strict';
////var http = require('http');
////var port = process.env.PORT || 1337;

////http.createServer(function (req, res) {
////    res.writeHead(200, { 'Content-Type': 'text/plain' });
////    res.end('Hello World123456\n');
////}).listen(port);

let express = require("express");
let app = express();

app.listen(1337, function () { console.log("Express Server is listening on port 1337..."); });//Binds and listens for connections on the specified port.

//設定routing(method + path ==> route)
app.get('/api/greeting', function (req, res, next) {
    res.send('<h1>歡迎光臨</h1>');
});

app.get('/api/greeting2', function (req, res, next) {
    res.send('<h1>hello</h1>');
});