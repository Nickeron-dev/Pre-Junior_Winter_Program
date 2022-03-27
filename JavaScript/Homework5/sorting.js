const arr = [{
    name: 'Bob',
    phoneNumber: '098-233-23-53'
},
{
    name: 'Peter',
    phoneNumber: '096-233-23-53'
},
{
    name: 'Ann',
    phoneNumber: '050-233-23-53'
}
]

function dynamicSort(property, sortOrder) {
    let order
    if (sortOrder === false)
    {
        order = -1;
    }
    else
    {
        order = 1;
    }
    return function (a, b)
    {
        let result = (a[property] < b[property]) ? -1 : (a[property] > b[property]) ? 1 : 0;
        return result * order;
    }
}

arr.sort(dynamicSort("name", false));

arr.forEach(function(entry)
{
    console.log(entry);
});

arr.sort(dynamicSort("name", true));

arr.forEach(function(entry)
{
    console.log(entry);
});
