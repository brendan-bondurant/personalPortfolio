export function showModal(modalId) {
    const modalElement = document.getElementById(modalId);
    if (modalElement && window.bootstrap && window.bootstrap.Modal) {
        const modal = new window.bootstrap.Modal(modalElement);
        modal.show();
    } else {
        console.error("Modal element or Bootstrap Modal class not found.");
    }
}
