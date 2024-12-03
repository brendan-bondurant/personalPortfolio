function toggleDarkMode(isDarkMode) {
    document.body.classList.toggle("dark-mode", isDarkMode);
    localStorage.setItem('darkMode', JSON.stringify(isDarkMode));
}

function initializeDarkMode() {
    const isDarkMode = JSON.parse(localStorage.getItem('darkMode')) || false;
    document.body.classList.toggle("dark-mode", isDarkMode);
    return isDarkMode;
}
