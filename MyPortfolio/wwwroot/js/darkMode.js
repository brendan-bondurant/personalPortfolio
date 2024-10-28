function toggleDarkMode(isDarkMode) {
  document.body.classList.toggle("dark-mode", isDarkMode);
  localStorage.setItem('darkMode', JSON.stringify(isDarkMode)); // Save setting for persistence
}

function initializeDarkMode() {
  const isDarkMode = JSON.parse(localStorage.getItem('darkMode')) || false;
  document.body.classList.toggle("dark-mode", isDarkMode);
  return isDarkMode;
}
