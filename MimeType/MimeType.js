function GetMIMEType(extMT, filename)
{
    var index = filename.lastIndexOf('.');
    if (index == -1)
        return "UNKNOWN";
    var extension = filename.substr(index + 1);
    for (var key in extMT)
    {
        if (extMT.hasOwnProperty(key) && key.toLowerCase() == extension.toLowerCase())
            return extMT[key];
    }
    return "UNKNOWN";
}

var N = parseInt(readline()); // Number of elements which make up the association table.
var Q = parseInt(readline()); // Number Q of file names to be analyzed.
var extMT = {};

for (var i = 0; i < N; i++) {
    var inputs = readline().split(' ');
    extMT[inputs[0]] = inputs[1];
}
for (var i = 0; i < Q; i++) {
    print(GetMIMEType(extMT, readline()));
}