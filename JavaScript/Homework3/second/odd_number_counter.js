let m = prompt("Введіть m (від цього числа будуть вираховуватися непарні)");
let n = prompt("Введіть n (до цього числа будуть вираховуватися непарні)");
if (m > 0 && n > m)
{
    let result = 1;
    for (let i = m; i <= n; i++)
    {
        if (i % 2 === 1)
        {
            result *= i;
        }
    }

    console.log("Добуток усіх непарних чисел між " + m + " та " + n + ": " + result);
}
else
{
    if (m <= 0)
    {
        console.log("Число m має бути більше 0");
    }
    else
    {
        console.log("Число n має бути більшим за число m");
    }
}