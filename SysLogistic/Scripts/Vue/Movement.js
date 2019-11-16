var appMovement = new Vue({
    el: '#appMovement'
    , data: {
        movementTypes: [],
        products: [],
        cboMovementType:'0',
        cboProduct: '0',
        txtCount: '',
        listDetails:[]
    }
    , methods: {
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
        this.ListProducts();
        this.ListMovemenTypes();
    }
});