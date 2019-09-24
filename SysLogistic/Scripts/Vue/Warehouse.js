var appWarehouse = new Vue({
    el: '#appWarehouse',
    data: {
        txtName: ''
        , txtDescription: ''
        , Warehouses: []
    },
    methods: {
        SaveWarehouse: function (event) {
            axios.post('/Warehouse/create', { Name: this.txtName, Description: this.txtDescription })
                .then(response => {
                    $('#modalWarehouse').modal('hide');
                    this.List();
                });
        },
        List: function (event) {
            axios.get("/Warehouse/List", {
                dataType: 'json'
            })
                .then(response => this.Warehouses = response.data.data);
        }
    },
    mounted() {
        this.List();
    }

});