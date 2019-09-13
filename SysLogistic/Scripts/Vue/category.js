const category = {
    Name: ''
    ,Description: ''
}

const eCategory = Object.create(category);

var app = new Vue({
    el: '#app',
    data: {
        txtName: '',
        txtDescription: ''
    }, methods: {
        SaveCategory: function (event) {
            
            eCategory.Name = this.txtName
            eCategory.Description = this.txtDescription
            const oCategory = JSON.stringify(eCategory);
            //alert("/Category/create?newCategory='" + oCategory+"'");

            axios.get("/Category/create?newCategory='" + oCategory + "'")
                .then(response => {
                    //this.info = response.data.bpi
                });
        }
    }
});