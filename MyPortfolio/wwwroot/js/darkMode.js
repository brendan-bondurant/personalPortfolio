function toggleDarkMode(isDarkMode = false) {
    document.body.classList.toggle("dark-mode", isDarkMode);
    localStorage.setItem('darkMode', JSON.stringify(isDarkMode)); // Save setting for persistence
}

function initializeDarkMode() {
    const isDarkMode = JSON.parse(localStorage.getItem('darkMode')) || false;

    // Add or remove the dark-mode class based on stored preference
    if (isDarkMode) {
        document.body.classList.add("dark-mode");
    } else {
        document.body.classList.remove("dark-mode");
    }

    return isDarkMode;
}
