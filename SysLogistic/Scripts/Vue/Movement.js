var appMovement = new Vue({
    el: '#appMovement'
    , data: {
        movementTypes: [],
        products: [],
        warehouses:[],
        cboMovementType:'0',
        cboProduct: '0',
        cboWarehouse:'0',
        txtCount: '0',
        txtDate:'',
        listDetails:[]
    }
    , methods: {
        CreateMovement: function (event)
        {
            axios.post('/Movement/Create', { ListDetails: this.listDetails, MovementTypeId: this.cboMovementType, WarehouseId: this.cboWarehouse, MovementDate: this.txtDate })
                .then(response => {

                })
        },
        ListWarehouses: function (event) {
            axios.get('/Movement/ListWarehouses', { dataType: 'json' })
                .then(response => {
                    this.warehouses = response.data.data
                });
        },
        AddProduct: function (event) {
            const detail = {
                ProductName:'',
                Count: 0
                ,ProductId:0
            };

            const objDetail = Object.create(detail);
            objDetail.ProductName = this.cboProduct.text;
            objDetail.Count = this.txtCount;
            objDetail.ProductId = this.cboProduct.id;
            this.listDetails.push(objDetail);
        },
        ListMovemenTypes: function (event) {
            axios.get('/Movement/ListMovementTypes', { dataType: 'json' })
                .then(response => {
                    this.movementTypes = response.data.data
                })
        },
        ListProducts: function (event) {
            axios.get('/Movement/ListProducts', { dataType: 'json' })
                .then(response => {
                    this.products = response.data.data
                })
        }
        
    }
    , mounted() {
        this.ListWarehouses();
        this.ListProducts();
        this.ListMovemenTypes();
    }
});