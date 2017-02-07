function sortNumber(a, b) {
    return a - b;
}

var N = parseInt(readline());

var powers = [N];

for (var i = 0; i < N; i++) {
    powers[i] = parseInt(readline());
}

powers.sort(sortNumber);
var minDist = powers[1] - powers[0];

for (var i = 1; i < powers.length - 1; i++)
{
    var dist = powers[i + 1] - powers[i];
    if (dist < minDist)
        minDist = dist;
}

print(minDist);