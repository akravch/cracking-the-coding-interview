namespace CTCI.Ch_01_Arrays_and_Strings.Task_07_Matrix_Rotation
{
    public class Rotation
    {
        public int[,] Rotate(int[,] matrix)
        {
            var side = matrix.GetLength(0) - 1;
            var layerCount = matrix.GetLength(0) / 2;

            for (var layerIndex = 0; layerIndex < layerCount; layerIndex++)
            {
                for (var y1 = layerIndex; y1 < side - layerIndex; y1++)
                {
                    var x1 = layerIndex;

                    var x2 = y1;
                    var y2 = side - layerIndex;

                    var x3 = y2;
                    var y3 = side - y1;

                    var x4 = y3;
                    var y4 = layerIndex;

                    var element1 = matrix[x1, y1];
                    var element2 = matrix[x2, y2];
                    var element3 = matrix[x3, y3];
                    var element4 = matrix[x4, y4];

                    matrix[x1, y1] = element4;
                    matrix[x2, y2] = element1;
                    matrix[x3, y3] = element2;
                    matrix[x4, y4] = element3;
                }
            }

            return matrix;
        }
    }
}