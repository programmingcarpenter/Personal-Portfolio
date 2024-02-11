document.addEventListener("DOMContentLoaded", function () {
    const taskInput = document.getElementById("taskInput");
    const addTaskButton = document.getElementById("addTaskButton");
    const taskList = document.getElementById("taskList");

    function addTask() {
        const taskText = taskInput.value.trim();
        if (taskText !== "") {
            const li = document.createElement("li");
            const listItemText = document.createElement('span');
            listItemText.textContent = taskText;

            const deleteButtonSpan = document.createElement('span');
            const deleteButton = document.createElement('button');

            deleteButtonSpan.appendChild(deleteButton);

            deleteButton.textContent = "Delete";
            deleteButton.addEventListener("click", function () {
                li.remove();
            });
            li.appendChild(listItemText);
            li.appendChild(deleteButtonSpan);

            taskList.appendChild(li);
            taskInput.value = "";
        } else {
            alert("Please enter a task.");
        }
    }

    addTaskButton.addEventListener("click", addTask);

    taskInput.addEventListener("keypress", function (event) {
        if (event.key === "Enter") {
            addTask();
        }
    });
});
