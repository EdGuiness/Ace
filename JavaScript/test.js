var n = 0.1; 
n += 0.2;
document.writeln('0.1 + 0.2 = ' + n); // 0.30000000000000004

document.writeln('0.1 + 0.2 === 0.3 is ' + ((0.1 + 0.2) === 0.3));


var dwarves = "bashful doc dopey grumpy happy sleepy sneezy";

var sevrawd = dwarves.split(' ').reverse().join(' ');

document.writeln(sevrawd);

document.writeln("Floating point? : " + parseFloat(0.1 * 1));

document.writeln("A: " + this);  // A: [object Window] (function of window)

var o = {
    f: function() {
        return this;
    }
};

document.writeln("B: " + o.f());  // object (function of object o)

var f = o.f;
document.writeln("C: " + f());  //window (function of window, no object involved)

var obj = {};
document.writeln("D: " + f.call(obj)); // object (object context obj supplied)

var o = {
    f: function() {
        var ff = function() {
            return this;
        };
        return ff();
    },
    g: {
           h: function() {
                  return this;
           }
       }
};


document.writeln("E: " + o.f()); // window (f is a function of o, but ff is not)

document.writeln("F: " + o.g.h()); // window (h is a function of nested object g)

