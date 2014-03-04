function TodoController($scope){
    $scope.todos = [
        {
            text: 'Item 1'
        }
    ];
    
    $scope.addTodo = function( todoText ){
        var todo = {
            text: todoText
        };
        
        $scope.todos.push( todo );
    }
    
    $scope.removeTodo = function( index ){
        $scope.todos.splice(index, 1);
    }
}