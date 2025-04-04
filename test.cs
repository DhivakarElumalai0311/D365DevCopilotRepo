const user = {
    id: 1,
    name: "Jane Doe",
    email: "jane.doe@example.com",
    isActive: true,
    displayInfo: function () {
        return `User [${this.id}]: ${this.name} (${this.email}) - Status: ${this.isActive ? "Active" : "Inactive"}`;
    },
    deactivate: function () {
        this.isActive = false;
    },
    activate: function () {
        this.isActive = true;
    }
};
