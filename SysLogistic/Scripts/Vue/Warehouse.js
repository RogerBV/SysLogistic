var appWarehouse = new Vue({
    el: '#appWarehouse',
    data: {
        txtName: ''
        , txtDescription: ''
        , Warehouses: []
    },
    methods: {
        SaveWarehouse: function (event) {

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