let arguments = prompt("Введіть аргументи для функції").split(" ");
let int_arguments = [];
for (let i = 0; i < arguments.length; i++)
{
    int_arguments[i] = parseInt(arguments[i]);
}
let answer = getSum(int_arguments);
alert("Результат: " + answer);

function getSum(args) {
    let sum = 0;
    if (args.length > 1) {
        for (let i = 1; i < args.length; i++) {
            sum += args[i];
        }
    }
    else {
        return 0;
    }

    return args[0] * sum;
}
