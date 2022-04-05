const tasks = [
    { text: 'Buy milk', done: false },
    { text: 'Pick up Tom from airport', done: false },
    { text: 'Visit party', done: false },
    { text: 'Visit doctor', done: true },
    { text: 'Buy meat', done: true }
];

let list = document.getElementById('list-of-tasks');
for (let i = 0; i < tasks.length; i++)
{
    let htmlliElement = document.createElement('li');
    let inputElement = document.createElement("input");
    inputElement.type = "checkbox";
    inputElement.checked = tasks[i].done;
    if (tasks[i].done)
    {
        inputElement.className = "list__item-checkbox list__item_done";
        htmlliElement.className = "list__item list__item_done";
    }
    else
    {
        inputElement.className = "list__item-checkbox";
        htmlliElement.className = "list__item";
    }

    htmlliElement.append(inputElement);
    htmlliElement.appendChild(document.createTextNode(tasks[i].text));
    list.appendChild(htmlliElement);
}
