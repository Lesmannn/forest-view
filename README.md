# forest-view



# Audio Manager

Perubahan pada Audio Manager dimana yang awalnya terdapat 4 BGM yang di load secara bersamaan meskipun itu tidak digunakan di dalam scene dirubah menjadi hanya 1 saja yang di load dan sisanya akan di unload sehingga dapat meningkatkan performa game

# Button Atlas

Perubahan pada button main menu dimana yang awalnya menggunakan sprite image yang terus menerus di load dirubah menjadi menggunakan sprite atlas yang di load ketika dibutuhkan saja

# Object Pooling

Perubahan pada spawn mushroom dimana yang awalnya mushroom akan ter-spawn terus menerus dan tidak akan hancur sampai game dihentikan dirubah menjadi object pooling dengan 150 pool object deactive dan dapat diaktifkan kapan saja, serta mushroom akan hancur setelah 3 detik setelah ter-spawn. sehingga meningkatkan FPS, penggunaan memory, dan lain-lain pada game

# Static Batching

Perubahan pada scene gameplay dimana yang awalnya semua prefabs tidak menggunakan metode static batching yang menyebabkan batches menjadi sangat besar dirubah menjadi menggunakan metode static batching sehingga dapat menurunkan batches menjadi lebih kecil.
