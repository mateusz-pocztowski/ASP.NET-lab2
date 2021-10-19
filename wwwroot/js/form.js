window.addEventListener('DOMContentLoaded', () => {
    const dateInput = document.querySelector('#Birthday');

    if (dateInput) {
        const today = new Date().toISOString().split("T")[0];

        dateInput.max = today;
    }
});