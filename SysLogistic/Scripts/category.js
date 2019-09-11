var app = new Vue({
    el: '#app',
    data: {
        txtName: '',
        txtDescription: '',
        txtPrecio:0.00
    }, methods: {
        SaveCategory: function (event) {
            alert(txtName);
        }
    }
});