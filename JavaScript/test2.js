x();

function x() {

    var x = 1;
    
    document.writeln("1: " + x);

    {
        var x = 4;
    }

    document.writeln("2: " + x);

    var f = function ()
    {
	document.writeln("3: " + x);
        var x = 3;
    };

    f();

    document.writeln("4: " + x);

}
