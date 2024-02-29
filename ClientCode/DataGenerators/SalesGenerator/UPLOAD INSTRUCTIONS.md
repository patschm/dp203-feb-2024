# Upload data to an Azure datalake
## Install azcopy
Download AzCopy from [Link here](https://learn.microsoft.com/en-us/azure/storage/common/storage-use-azcopy-v10#download-azcopy)

## Install Azure CLI tools (if not done already) and login
```cmd
az login
```
## Create a SAS token for the container
Maybe easier doing this in the portal
```cmd
az storage container generate-sas --account-name <storage-account> -n <container> --permissions acdlrw --expiry 2024-08-12
```
## Upload data

Upload generated folders by using azcopy

```
azcopy.exe copy "sales_small" "<sas_url>" --recursive
```

