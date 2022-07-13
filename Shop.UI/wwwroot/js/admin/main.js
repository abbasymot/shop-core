var app = new Vue({
    el: '#app',
    data: {
        id: 0,
        price: 0,
        show: true,
        loading: false,
        objectIndex: 0,
        productModel: {
            title: "عنوان",
            description: "توضیحات",
            price: 1,
        },
        products: []
    },
    methods: {
        getProduct(id){
            this.loading = true;
            axios.get('/Admin/products/' + id)
            .then(res => {
                this.products = res.data;
            })
            .catch(err =>{
                console.log(err);
            })
            .then(() =>{
                this.loading = false;
            });
        },
        getProducts(){
            this.loading = true;
            axios.get('/Admin/products')
            .then(res => {
                this.products = res.data;
            })
            .catch(err =>{
                console.log(err);
            })
            .then(() =>{
                this.loading = false;
            });
        },
        createProduct(){
            this.loading = true;
            axios.post("/Admin/products/", this.productModel)
            .then(res => {
                this.products.push(res.data);
            })
            .catch(err =>{
                console.log(err);
            })
            .then(() =>{
                this.loading = false;
            });
        },
        // updateProduct(){
        //     this.loading = true;
        //     axios.put("/Admin/products/", this.productModel)
        //     .then(res => {
        //         this.products.splice(thie.objectIndex, 1, res.data);
        //     })
        //     .catch(err =>{
        //         console.log(err);
        //     })
        //     .then(() =>{
        //         this.loading = false;
        //     });
        // },
        // editProduct(product, index){
        //     objectIndex = index;
        //     this.productModel = {
        //         id: product.id,
        //         title: product.title,
        //         description: product.description,
        //         price: product.price,
        //     }
        // },
        // deleteProduct(id, index){
        //     this.loading = true;
        //     axios.delete('/Admin/products/' + id)
        //     .then(res => {
        //         this.products.splice(index, 1)
        //     })
        //     .catch(err =>{
        //         console.log(err);
        //     })
        //     .then(() =>{
        //         this.loading = false;
        //     });
        // },
    },
    computed: {
        formatPrice: function() {
            return this.price + " هزار تومان"
        }
    }
});

